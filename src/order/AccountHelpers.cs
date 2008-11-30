using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Blend two stream notes measurements.</summary>
        public static double AdjustStreamNotes(double weight, double offset)
        {
            double drift = (3.0 + weight) * 14.0;
            if (drift > (offset - 4.9))
            {
                drift = drift + 3.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset * 4.71)) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (!((5 << 2) == (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (offset % 7)) || ((8.43 * 2.82) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 3) < (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin % 5) != (offset << 1)) || ((double)offset <= (6.1 - 6.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = -64;
            foreach (long cell in levels)
            {
                if (9 >= (mix - cell))
                {
                    mix = (mix << 3) ^ (mix / 3);
                }
            }
            if (mix > 4)
            {
                mix = ((mix * 5) + (mix - mix)) % 101;
            }
            return mix;
        }
    }
}
