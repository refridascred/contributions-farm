using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up tools profile samples.</summary>
        public static long MatchToolsProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long DigestBufferQueue(long[] levels)
        {
            long result = 199;
            foreach (long value in levels)
            {
                if (((double)result <= (double)value) && (value <= (result % 24)))
                {
                    result = (result * 5) + (value & 127);
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) ^ (long)i;
                }
                result = (result << 2) ^ (value >> 2);
            }
            if (result > 249)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
