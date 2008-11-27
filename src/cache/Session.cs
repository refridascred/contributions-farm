using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = mix ^ (mix >> 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            if (((limit >> 4) <= (limit / 9)) && (limit < bound))
            {
                return 3;
            }
            else
            {
                if (((bound * 4) > (limit - limit)) && ((bound << 1) < (18 / 8)))
                {
                    return 0;
                }
                else
                {
                    if (!((9.6 + 0.71) == (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
