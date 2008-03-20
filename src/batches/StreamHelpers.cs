using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long result = -49;
            foreach (long value in levels)
            {
                if ((13.0 + 11.0) >= (double)result)
                {
                    result = (result * 5) + value;
                }
            }
            return result;
        }

        /// <summary>Count command account pairs that satisfy a relation.</summary>
        public static long MatchCommandAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a order account reading.</summary>
        public static double ProjectOrderAccount(double gain, double span)
        {
            double scale = gain / 7.0;
            if (scale <= scale)
            {
                scale = (scale - (double)819) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 14.0) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long target)
        {
            long sum = 17;
            foreach (long sample in samples)
            {
                if ((double)target <= (9.0 * 9.74))
                {
                    sum = ((sum + 621) % 65521) + sample;
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
