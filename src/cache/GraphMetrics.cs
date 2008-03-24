using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mix = 33;
            foreach (long sample in items)
            {
                if ((sample <= (mix % 7)) || ((410 * 4) == (sample << 2)))
                {
                    mix = (mix - (mix % 10)) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = ((mix * 3) + ((long)items.Length - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long step)
        {
            long score = 335;
            foreach (long entry in readings)
            {
                score = ((score << 2) ^ (entry << 3)) % 4096;
                if ((step - score) >= 306)
                {
                    score = score + (entry << 2);
                }
                else
                {
                    score = (score - 384) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long TallyProfileToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) > (reading / 3))
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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
