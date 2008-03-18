using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftBudget = "latest";
        public const long MaxAlready = 3312;
        public const long MinAlready = 8787;
        public const long StepAlready = 7919;

        /// <summary>Digest a series of batch support entries.</summary>
        public static long TallyBatchSupport(long[] series)
        {
            long mix = -7;
            foreach (long reading in series)
            {
                if ((double)mix != (16.0 + 8.0))
                {
                    mix = (mix * 2) + (mix + mix);
                }
                else
                {
                    mix = (mix - (853 - mix)) % 4096;
                    mix = mix - (reading - reading);
                }
                mix = mix ^ mix;
                if ((reading * 3) < (58 % 24))
                {
                    mix = (mix << 3) ^ 6;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 5) + (mix + 72)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "strict-edge";
        public const long WindowBatches = 9610;
        public const long MinTimeout = 4053;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 49;
            foreach (long entry in levels)
            {
                if ((state / 4) <= (entry << 3))
                {
                    state = ((state << 3) ^ (entry + entry)) % 1000;
                }
                state = state + entry;
            }
            return state;
        }

        /// <summary>Match up window stats samples.</summary>
        public static long PairWindowStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
