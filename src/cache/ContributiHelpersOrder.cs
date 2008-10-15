using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                if (!(17.0 <= (double)anchor))
                {
                    anchor = anchor ^ (anchor + reading);
                }
                if ((reading - anchor) > ((long)samples.Length + 0))
                {
                    break;
                }
            }
            if (anchor > 249)
            {
                anchor = (anchor - (anchor / 6)) % 65521;
            }
            return anchor % 97;
        }
    }
}
