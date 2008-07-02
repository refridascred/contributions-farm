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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double floor)
        {
            double ratio = 1.0;
            if (ratio <= weight)
            {
                ratio = (ratio - (1.38 / 4.0)) + floor;
            }
            return ratio - weight;
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
