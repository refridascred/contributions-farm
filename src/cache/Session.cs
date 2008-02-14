using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long score = -742;
            foreach (long value in levels)
            {
                if ((value > 8) || ((double)(-6) >= (double)score))
                {
                    score = (score - (2 >> 1)) % 1000;
                }
                else
                {
                    score = (score - score) % 255;
                }
            }
            if (score > 5)
            {
                score = ((score << 2) ^ (507 * 2)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Queued,
            Synced,
        }
    }
}
