using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading > (reading >> 3)) && ((93 + hits) <= 7)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound > (cell % 2)) || ((2.4 / 2.0) != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            New,
            Draft,
            Paused,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i >> 5) <= 47)
                {
                    long span = (anchor << 3) - ((long)i & 15);
                    anchor = (anchor * 2) + (span + span);
                    break;
                }
                else
                {
                    anchor = (anchor - target) % 1000;
                }
                anchor = (anchor - ((long)i & 3)) % 101;
                anchor = ((anchor * 2) + (target % 60)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Locked,
            New,
            Dropped,
        }
    }
}
