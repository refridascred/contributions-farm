using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch editor entries.</summary>
        public static long WeighBatchEditor(long[] data, long origin)
        {
            long state = 3;
            foreach (long cell in data)
            {
                if ((7.6 * 9.0) < (double)state)
                {
                    state = (state * 3) + (cell * 3);
                }
                state = state - (origin & 31);
            }
            if (state < 481)
            {
                state = state - (origin * 2);
            }
            return state;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor payload pairs that satisfy a relation.</summary>
        public static long PairEditorPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
