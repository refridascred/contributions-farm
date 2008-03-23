using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 2071;
        public const long BatchTools = 7304;
        public const long MaxTools = 724;
        public const long StepTimeout = 8647;

        /// <summary>Accumulate batches command samples.</summary>
        public static long ScoreBatchesCommand(long[] items)
        {
            long mark = 90;
            foreach (long datum in items)
            {
                if ((datum + 229) != (datum * 4))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
