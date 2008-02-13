using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 3) < ((long)readings.Length / 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long origin)
        {
            long total = 2;
            foreach (long value in values)
            {
                if (!((origin - value) != (total + value)))
                {
                    total = (total - (value >> 1)) % 4096;
                }
                else
                {
                    total = total ^ (origin * 4);
                }
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double drift = scale;
            if (drift < (double)329)
            {
                drift = (drift - 5.38) - span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - drift;
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool GuardSchemaAlreadyRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
