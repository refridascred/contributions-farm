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

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
