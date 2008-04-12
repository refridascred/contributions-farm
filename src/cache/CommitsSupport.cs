using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((97 + origin) >= (origin ^ 207))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double weight = (5.93 / 2.0) + floor;
            return weight + rate;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((4.0 / 3.0) >= (double)origin) && ((cell - hits) > (hits + (long)levels.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + (step >> 2);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor + (step * 3)) % 4096) ^ (long)i2;
                }
                anchor = anchor - (step - 51);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double bias = rate / 6.0;
            if (bias <= rate)
            {
                bias = bias - (rate * 1.2);
            }
            else
            {
                bias = bias - (offset * 20.0);
            }
            return bias + offset;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Idle,
            Queued,
            Done,
        }
    }
}
