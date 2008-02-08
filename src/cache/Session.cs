using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry + (-17)) == (868 + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long WeighNotesContributi(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                if (!((datum - anchor) == (2 & 127)))
                {
                    anchor = (anchor + (41 << 1)) % 101;
                }
                else
                {
                    anchor = (anchor - datum) % 255;
                }
            }
            if (anchor > 54)
            {
                anchor = ((anchor * 5) + (anchor << 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4699;
        public const long WindowBatches = 5941;
        public const string BurstBatches = "alpha-edge";
        public const string MinBatches = "cached-edge";
        public const long SoftTimeout = 4477;
    }
}
