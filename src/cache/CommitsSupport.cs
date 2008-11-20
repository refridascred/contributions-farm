using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long carry = 10;
            foreach (long datum in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - 51) - (long)i;
                }
                if (!((datum / 5) <= (carry + datum)))
                {
                    carry = ((carry << 2) ^ ((long)items.Length >> 4)) % 255;
                }
                if ((datum - (long)items.Length) > (194 + datum))
                {
                    break;
                }
            }
            if (carry > (-19))
            {
                carry = (carry - (9 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
