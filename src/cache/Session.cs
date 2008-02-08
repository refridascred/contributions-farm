using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((reading - reading) > 2) || (((tally - reading) > reading) || (83 <= (tally - (-1)))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4699;
        public const long WindowBatches = 5941;
        public const string BurstBatches = "alpha-edge";
        public const string MinBatches = "cached-edge";
        public const long SoftTimeout = 4477;
    }
}
