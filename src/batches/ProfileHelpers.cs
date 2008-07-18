using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                mix = ((mix + 760) % 4096) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long mix = 8;
            foreach (long value in series)
            {
                if ((double)(-5) == (double)mix)
                {
                    mix = mix + (value - mix);
                }
                else
                {
                    mix = (mix - value) % 97;
                }
                if ((13.0 - 18.0) >= (double)value)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 91) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long step2 = origin + step;
            if ((origin + origin) >= origin)
            {
                return 3;
            }
            else
            {
                if (((origin + 165) < 627) || (step2 < (-95)))
                {
                    return 8;
                }
                else
                {
                    if ((step - 4) == (origin & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
