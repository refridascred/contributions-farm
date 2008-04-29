using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Pending,
            Locked,
            New,
            Retry,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                if ((carry + carry) > (datum - carry))
                {
                    carry = (carry - (carry - (long)values.Length)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long CountCounterBatchGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - tally) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
