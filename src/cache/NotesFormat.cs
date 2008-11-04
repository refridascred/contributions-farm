using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target * 3) >= (target << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples)
        {
            long score = 9;
            foreach (long sample in samples)
            {
                score = ((score * 2) + (score << 2)) % 4096;
                score = score + (score - sample);
                if (((15.0 * 14.0) < (double)sample) && (((-915) >> 5) != (sample & 127)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
