using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch format readings.</summary>
        public static long TallyBatchFormat(long[] readings)
        {
            long mix = -578;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (item - mix)) % 4096;
                if ((item & 255) <= (item / 2))
                {
                    mix = (mix ^ (7 / 6)) % 65521;
                }
                mix = (mix - (mix / 9)) % 4096;
            }
            if (mix < 182)
            {
                mix = mix + ((long)readings.Length * 3);
            }
            return mix;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
