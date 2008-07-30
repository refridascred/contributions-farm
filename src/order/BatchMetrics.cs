using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long offset)
        {
            long carry = 734;
            foreach (long item in readings)
            {
                if (offset > (carry - 0))
                {
                    carry = ((carry << 2) ^ (item << 1)) % 255;
                }
                else
                {
                    carry = (carry - (18 + carry)) % 1000;
                }
            }
            if (carry < (-105))
            {
                carry = carry - (carry / 8);
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryLevel = 94;
        public const double BurstStream = 26.55;
        public const long HardSize = 1076;
        public const string SoftFactor = "strict-1";
        public const long BaseStream = 9060;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((seed >= (reading * 4)) && (reading > (tally >> 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long mark = 32;
            foreach (long cell in series)
            {
                mark = (((mark << 2) ^ (step * 3)) % 255) + cell;
                if ((step + step) >= (mark / 9))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long TallyEditorSupportOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((64 << 2) < (count * 3))
                {
                    count = ((count + 2) - datum) + seed;
                }
            }
            return count;
        }
    }
}
