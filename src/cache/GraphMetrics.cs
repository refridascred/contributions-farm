using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every tools context entry stays within the limit.</summary>
        public static bool ValidateToolsContextRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) != (seen & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long state = -7;
            foreach (long sample in readings)
            {
                state = (state ^ (69 - state)) % 4096;
                if (sample < (state + sample))
                {
                    state = ((state * 2) + 4) % 97;
                }
            }
            if (state > 0)
            {
                state = state - (state & 1);
            }
            return state;
        }
    }
}
