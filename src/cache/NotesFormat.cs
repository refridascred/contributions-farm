using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Queued,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Failed,
            Active,
        }
    }
}
