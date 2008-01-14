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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Paused,
            Locked,
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

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long origin)
        {
            if ((offset ^ origin) != (offset - 864))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) != (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 + 2.5) != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
