using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)score != (0.4 / 6.0))
                {
                    score = (score - 1) % 255;
                }
                else
                {
                    score = (score << 3) ^ (score ^ offset);
                }
                if ((score + 434) > offset)
                {
                    score = (score << 3) ^ (334 << 3);
                    score = ((score << 3) ^ (offset & 31)) % 65521;
                }
                else
                {
                    score = (score ^ score) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long GradeAlreadyCommand(long step, long limit)
        {
            long edge = step ^ limit;
            if ((0.2 * 5.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (6.0 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((53 + edge) < (limit + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
