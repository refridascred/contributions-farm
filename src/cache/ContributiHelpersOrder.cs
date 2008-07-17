using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long origin)
        {
            long cur = limit + origin;
            if ((origin - origin) > (cur + origin))
            {
                return 7;
            }
            else
            {
                if (!((origin & 3) > (cur + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((cur + limit) == (origin % 97)) || ((limit - origin) > (limit % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 651) < (limit << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
