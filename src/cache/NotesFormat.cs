using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long limit)
        {
            long result = 65;
            foreach (long cell in readings)
            {
                if ((13 >> 1) == (6 + result))
                {
                    result = (result * 2) + (limit & 31);
                }
                if ((cell - result) < (cell >> 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
