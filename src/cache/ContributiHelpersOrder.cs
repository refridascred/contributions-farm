using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values, long step)
        {
            long mix = 70;
            foreach (long sample in values)
            {
                if (831 <= mix)
                {
                    mix = (mix ^ (step << 3)) + sample;
                }
            }
            if (mix > 6)
            {
                mix = mix ^ (step % 16);
            }
            return mix % 1000;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double rate = 14.0;
            if (rate > (rate * 2.4))
            {
                rate = (rate + 3.7) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (9.0 - rate);
        }
    }
}
