using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double load = offset - (double)879;
            if (load <= 3.3)
            {
                load = (load + (load + 9.0)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftLevel = 1278;
        public const string StepSupport = "fallback";
        public const long MaxSize = 9135;
        public const string BurstSupport = "local";

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long mix = -29;
            foreach (long datum in data)
            {
                if ((datum - 963) < (datum + mix))
                {
                    mix = ((mix * 5) + (datum % 16)) % 65521;
                    mix = (mix << 2) ^ (datum << 2);
                }
                else
                {
                    mix = ((mix * 5) + 948) % 4096;
                }
                mix = mix + mix;
            }
            if (mix > 565)
            {
                mix = (mix ^ (mix % 7)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Active,
            Synced,
        }
    }
}
