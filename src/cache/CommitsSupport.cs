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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema already readings.</summary>
        public static long CombineSchemaAlready(long[] readings, long offset)
        {
            long carry = 716;
            foreach (long item in readings)
            {
                carry = (carry - (offset & 255)) - item;
            }
            return carry;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) >= 1) || ((-84) > datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
