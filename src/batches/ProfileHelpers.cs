using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long step)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = (result - (step & 127)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 2) + mark;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool VerifyBatchChannelLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load > (span + load))
            {
                load = load + (4.2 / 8.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Match up editor checks samples.</summary>
        public static long PairEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
