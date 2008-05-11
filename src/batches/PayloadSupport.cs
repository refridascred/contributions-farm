using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!!((double)seen < (9.0 - 4.1)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Match up editor route samples.</summary>
        public static long CompareEditorRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 108;
        public const long SoftChannel = 1306;
        public const long HardChannel = 2348;
        public const long DefaultRatio = 6249;
        public const string MaxChannel = "standard";
    }
}
