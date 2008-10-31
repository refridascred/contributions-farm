using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardBudget = 8692;
        public const long MaxInterval = 2452;
        public const string StepWidth = "legacy-edge";
        public const long DefaultTimeout = 5011;
        public const long HardPayload = 2980;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double drift = ratio - (16.0 / 9.0);
            if (drift <= (ratio - drift))
            {
                drift = drift + (double)97;
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.0) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] values, long step)
        {
            long mix = -534;
            foreach (long entry in values)
            {
                if ((step + 4) >= mix)
                {
                    mix = ((mix + step) % 65521) + entry;
                }
            }
            return mix % 4096;
        }
    }
}
