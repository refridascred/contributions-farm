using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if ((floor % 2) < floor)
            {
                return 0;
            }
            else
            {
                if ((offset / 8) <= (floor << 2))
                {
                    return 8;
                }
                else
                {
                    if (floor > (6 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (1.0 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long AuditFormatStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((7.6 * 5.48) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit session order readings against a rule.</summary>
        public static long CountSessionOrderHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((target % 97) == ((-5) & 15))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + gain))
            {
                ratio = ratio - (double)740;
            }
            else
            {
                ratio = ratio - (9.94 - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
