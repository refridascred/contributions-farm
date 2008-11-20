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

        /// <summary>Match up farm batch samples.</summary>
        public static long MatchFarmBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
