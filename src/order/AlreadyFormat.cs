using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8296;
        public const double BatchInterval = 82.07;
        public const string BatchCluster = "cached";

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ ((long)i * 5)) % 255;
                }
                if (!((6.3 + 6.67) == (double)entry))
                {
                    anchor = (anchor * 3) + (long)readings.Length;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry * 5)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((27 + reading) > target) && (8.3 >= (double)reading)))
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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Failed,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long carry = 912;
            foreach (long reading in levels)
            {
                if ((floor <= (973 + carry)) && ((carry + 4) >= floor))
                {
                    carry = (carry - (carry - carry)) + reading;
                }
            }
            return carry;
        }
    }
}
