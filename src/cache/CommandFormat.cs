using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7969;
        public const double MaxTimeout = 86.21;
        public const long IdleWidth = 6705;
        public const long BaseToken = 7279;

        /// <summary>Fold a list of account stats readings.</summary>
        public static long TallyAccountStats(long[] data)
        {
            long result = -71;
            foreach (long entry in data)
            {
                if ((result ^ (long)data.Length) < (result + (long)data.Length))
                {
                    result = result + 778;
                }
                if (((result + entry) >= result) || ((entry * 5) >= (entry ^ result)))
                {
                    result = (result - (entry * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long step)
        {
            long span = floor - step;
            if (!((5.3 + 4.76) == (double)span))
            {
                return 8;
            }
            else
            {
                if (step > 135)
                {
                    return 3;
                }
                else
                {
                    if (((floor >> 4) < step) || ((51 + span) != (span - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((span << 1) <= ((-954) / 2)) && (29 <= (span + floor)))
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
}
