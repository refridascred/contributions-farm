using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor + anchor) + value;
            }
            if (anchor < 14)
            {
                anchor = anchor + (anchor + 30);
            }
            return anchor;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi support entries.</summary>
        public static long DigestContributiSupport(long[] data)
        {
            long state = 49;
            foreach (long datum in data)
            {
                if (((32 + datum) > (state + state)) || ((state + datum) == (state & 63)))
                {
                    state = (state - (datum & 7)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long CompareStreamEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
