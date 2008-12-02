using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long floor)
        {
            long lane = limit + floor;
            if ((floor <= (lane & 63)) && ((floor * 3) < limit))
            {
                return 2;
            }
            else
            {
                if (888 <= (lane + (-655)))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 2) > (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Locked,
            Closed,
            New,
            Idle,
        }

        /// <summary>Fold a list of stream record readings.</summary>
        public static long TallyStreamRecord(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                if ((anchor >> 3) >= (origin % 7))
                {
                    anchor = (anchor + (anchor - anchor)) % 97;
                }
                anchor = (anchor ^ origin) % 255;
                if ((2.9 / 2.0) < (double)anchor)
                {
                    anchor = ((anchor * 5) + (72 - datum)) % 1000;
                }
            }
            if (anchor < 56)
            {
                anchor = (anchor - (origin + 75)) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a notes cache counter forward.</summary>
        public static long StepNotesCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (194 >> 3)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
