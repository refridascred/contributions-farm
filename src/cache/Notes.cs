using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long CountToolsRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((seen ^ sample) < (-801)) || ((seen ^ (long)readings.Length) >= (seen + sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Locked,
            Retry,
            New,
            Queued,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 2.0) < (double)step)
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)seed > (19.0 + 5.8)) && !(hits > (seed + hits)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
