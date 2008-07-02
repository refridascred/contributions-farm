using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((hits / 3) <= hits) || ((85 - 689) >= hits)) && (step <= (hits - hits)))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long bound)
        {
            long bound2 = limit + bound;
            if ((limit / 4) != (limit + 1))
            {
                return 4;
            }
            else
            {
                if ((bound + bound2) <= (limit + limit))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
