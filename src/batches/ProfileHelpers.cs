using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long SeriesGraphContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((2.48 / 7.0) != (double)score)
                {
                    score = (score ^ floor) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ floor) ^ (long)i2;
                    score = (score ^ floor) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 30.55;
        public const long MinRatio = 3846;
        public const double MaxProfile = 16.49;
        public const long IdleCount = 7089;
        public const long WindowRatio = 2837;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long step)
        {
            if ((step ^ step) >= (step ^ 23))
            {
                return 3;
            }
            else
            {
                if (((floor + step) >= floor) && (floor < step))
                {
                    return 2;
                }
                else
                {
                    if ((step + floor) != (floor ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
