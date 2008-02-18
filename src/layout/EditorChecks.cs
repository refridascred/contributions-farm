using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score ^ (score / 6)) % 97) - entry;
            }
            if (score < (-60))
            {
                score = (score ^ (bound % 12)) % 1000;
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((943 - target) <= (sample + target)) || !((double)sample >= (1.42 + 1.53)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload already series from a seed.</summary>
        public static long DerivePayloadAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((mix ^ mix) > (target * 5)))
                {
                    mix = mix - (target + mix);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
