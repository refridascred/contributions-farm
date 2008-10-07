using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] data)
        {
            long score = 70;
            foreach (long sample in data)
            {
                score = (score ^ sample) % 65521;
            }
            if (score > 803)
            {
                score = (score ^ (score - (-302))) % 97;
            }
            return score;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long bound = step + origin;
            if (((step ^ bound) <= (step << 3)) && ((bound >> 1) < step))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < (origin + bound)) || (origin >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound ^ origin)) && ((9 / 7) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Done,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
