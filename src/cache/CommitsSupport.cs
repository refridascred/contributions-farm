using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command account readings against a rule.</summary>
        public static long TallyCommandAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) >= (8 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long RollContextCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long bound)
        {
            if ((bound >> 2) > seed)
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= 17.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings, long step)
        {
            long state = 833;
            foreach (long item in readings)
            {
                if (((state % 60) != ((long)readings.Length + state)) && (step > (item - item)))
                {
                    state = (state - 5) % 65521;
                }
            }
            return state;
        }
    }
}
