using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                mix = mix ^ mix;
                if (((reading & 127) > (mix + reading)) && (reading <= (reading + reading)))
                {
                    mix = ((mix * 5) + 25) % 101;
                    mix = (mix + (reading + reading)) % 97;
                    break;
                }
                mix = (mix - (reading * 4)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)item == (5.0 / 5.0)) && (item <= (55 & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long state = 3;
            foreach (long sample in values)
            {
                state = (state * 4) + state;
                if ((double)sample <= (3.93 * 8.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
