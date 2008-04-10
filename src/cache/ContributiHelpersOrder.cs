using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 96.1;
        public const string MaxReport = "alpha-edge";
        public const long DefaultTimeout = 1315;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long step)
        {
            long mark = 272;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (step * 2)) % 65521;
                mark = ((mark << 3) ^ (mark << 3)) % 1000;
                if (step >= (mark + step))
                {
                    mark = (mark << 2) ^ (step ^ mark);
                }
                else
                {
                    mark = (mark << 3) ^ (step - value);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Done,
            Locked,
            Idle,
        }
    }
}
