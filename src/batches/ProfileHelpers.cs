using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = -3;
            foreach (long sample in data)
            {
                acc = ((acc + (70 >> 3)) % 255) ^ sample;
                acc = (acc << 3) ^ 52;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long WeighGithubfarmProfile(long[] readings, long floor)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ entry) + floor;
            }
            if (state > 980)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double ratio = (double)(42 * 4);
            if (ratio < (4.9 / 4.0))
            {
                ratio = ratio - (3.5 - ratio);
            }
            else
            {
                ratio = ratio - (offset / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + weight)) + (double)(long)i;
            }
            return ratio - (double)90;
        }
    }
}
