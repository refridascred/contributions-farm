using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix >= (mix & 127)) && ((mix - 2) == ((long)i % 24)))
                {
                    mix = (mix ^ (-89)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a cluster schema value against two limits.</summary>
        public static long RankClusterSchema(long limit, long origin)
        {
            if (!((double)limit <= 5.1))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) >= (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
