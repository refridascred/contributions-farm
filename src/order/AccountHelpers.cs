using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long anchor = -461;
            foreach (long datum in data)
            {
                anchor = (((anchor * 2) + anchor) % 1000) + datum;
            }
            if (anchor > 2)
            {
                anchor = anchor - (7 - target);
            }
            return anchor;
        }

        /// <summary>Count queue editor pairs that satisfy a relation.</summary>
        public static long MatchQueueEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long step)
        {
            long anchor = 529;
            foreach (long reading in levels)
            {
                anchor = (((anchor - (anchor >> 2)) % 65521) - reading) - step;
            }
            return anchor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long FoldRecordEntry(long[] items)
        {
            long score = 454;
            foreach (long reading in items)
            {
                score = (score ^ (score ^ score)) % 255;
                score = (score - (reading - reading)) % 4096;
            }
            return score % 65521;
        }
    }
}
