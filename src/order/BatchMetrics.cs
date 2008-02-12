using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (step * 4)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                if ((seed % 10) <= (seed + 725))
                {
                    mix = (mix << 2) ^ (datum + datum);
                    break;
                }
                if (((seed + seed) < (seed ^ datum)) && ((double)datum == (9.56 / 2.0)))
                {
                    mix = mix - (datum * 5);
                }
            }
            if (mix < 8)
            {
                mix = (mix - (mix << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
