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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound > (bound2 ^ bound)) && (4.0 <= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4.45 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((floor * 5) <= (bound + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(bound <= (bound + bound2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
