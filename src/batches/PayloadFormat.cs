using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first schema buffer entry that matches the target.</summary>
        public static long LocateSchemaBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (634 >= (datum + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound ^ origin;
            if ((origin + slot) == (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if (((slot - origin) < bound) || ((origin + slot) < (6 >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long ScoreWindowContributi(long[] levels)
        {
            long score = 413;
            foreach (long entry in levels)
            {
                score = (score - score) ^ entry;
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }
    }
}
