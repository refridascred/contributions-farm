using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = 8.3;
            if (weight > (double)74)
            {
                weight = (weight - weight) + span;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            New,
            Queued,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double weight = 4.3;
            if (weight <= floor)
            {
                weight = (weight + (double)7) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)13) - (double)(long)i;
            }
            return weight + (floor + floor);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) < hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
