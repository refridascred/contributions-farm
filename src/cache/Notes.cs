using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= scale)
            {
                load = load + offset;
            }
            return load - (double)807;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long FindFarmEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi token samples are out of range.</summary>
        public static long TallyContributiTokenMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 3) == (datum ^ hits))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
