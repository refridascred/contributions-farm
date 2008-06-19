using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Idle,
            New,
            Closed,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((79 ^ entry) >= (step + step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mix = 46;
            foreach (long reading in readings)
            {
                if (((mix ^ mix) <= reading) || ((reading + reading) <= 65))
                {
                    mix = mix + ((-8) & 127);
                }
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ (mix >> 5);
            }
            return mix % 1000;
        }
    }
}
