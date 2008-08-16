using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Draft,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a order farm figure with a bias.</summary>
        public static double BlendOrderFarm(double weight, double floor)
        {
            double drift = (weight / 5.0) - weight;
            if (drift < floor)
            {
                drift = drift + (double)840;
            }
            else
            {
                drift = drift + (floor + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (weight * 5.0)) + (double)(long)i;
            }
            return drift + (3.8 * 4.35);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)acc > (double)limit)
                {
                    acc = ((acc * 2) + ((long)i << 3)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
