using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double AdjustCommandFarm(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (bias * 4.0)) + (double)(long)i) + span;
            }
            return rate + (double)80;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (447 >= (matches / 8))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long MatchClusterReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
