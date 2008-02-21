using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long anchor = 639;
            foreach (long reading in readings)
            {
                anchor = (((anchor ^ anchor) % 101) - reading) - limit;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long bound)
        {
            long anchor = 90;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)(-5))
                {
                    anchor = (anchor - reading) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (bound + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
