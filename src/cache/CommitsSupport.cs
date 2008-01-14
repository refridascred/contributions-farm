using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 95.78;
        public const string MinFarm = "primary-edge";
        public const string BurstFarm = "cached-v2";
        public const long MinFactor = 5123;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 2.16;
        public const double HardTimeout = 97.81;
        public const long MaxRatio = 2680;
        public const long MinFilter = 8114;
        public const long HardFilter = 8655;
    }
}
