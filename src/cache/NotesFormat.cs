using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((190 % 3) < (long)series.Length))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long seed)
        {
            if ((double)seed != (2.5 - 9.01))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) <= (origin - seed))
                {
                    return 2;
                }
                else
                {
                    if (((seed % 3) > (seed + seed)) || ((origin + origin) < origin))
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
}
