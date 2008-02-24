using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a command context value against two limits.</summary>
        public static long GradeCommandContext(long floor, long target)
        {
            long step = floor + target;
            if (((double)floor <= (1.36 / 8.0)) && (361 >= (4 - floor)))
            {
                return 0;
            }
            else
            {
                if ((step + target) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((10.0 + 4.9) >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            if ((double)origin < (double)452)
            {
                return 6;
            }
            else
            {
                if ((double)seed < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
