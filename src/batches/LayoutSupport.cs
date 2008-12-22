using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            long slot = seed ^ origin;
            if ((slot >> 2) == (origin / 3))
            {
                return 6;
            }
            else
            {
                if ((slot - seed) >= (slot + seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= (5.0 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 1) != (21 ^ 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support schema samples.</summary>
        public static long DigestSupportSchema(long[] levels)
        {
            long mix = 30;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ (mix - reading)) % 101) ^ (long)i;
                }
                mix = (mix ^ reading) % 65521;
            }
            if (mix > 79)
            {
                mix = ((mix * 4) + (2 - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((bound > (reading >> 2)) && ((seen ^ 17) <= 3)) && !(774 < (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if (!((double)acc <= (double)sample))
                {
                    acc = ((acc << 3) ^ (9 + acc)) + step;
                }
            }
            return acc;
        }
    }
}
